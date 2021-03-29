# SDL2 environment setup

A step-by-step tutorial about how to set up a project to be able to use SDL2
library in CLion.

## Setup guide

There are two different use cases for setting up a project.

Happy drawing :)

### Single executable

This project setup is useful when you want to work on a single big project,
like Wanderer.

[Single executable setup](env-setup-single-executable.md)

### Multiple executables

This project setup is useful when you want to work on little exercises
and be able to switch quickly between them, like the Drawing workshop.

[Multiple executables setup](env-setup-multiple-executables.md)

## CMake explanation

[CMake](https://cmake.org/overview/) is a tool which makes it easier to
build complicated projects with lot of files and libraries.
This section tries to make it easierfor you to understand the commands
in the CMake files.

### Variables

This is how you create and set a variable in cmake:
`set(SDL2_ROOT_PATH C:/SDL2.0.8`

This is useful for the same reason as in programming languages as well.
You can use the same value at multiple places.
If you want to use this variable you need to write this: `${SDL2_ROOT_PATH}`

### Control flow

You can write if statements in a cmake file. For example this only runs on
windows systems:

```cmake
IF(WIN32)
    set(MINGW_VERSION i686-w64-mingw32)
ENDIF()
```

Also you can write loops in a cmake file. For example this code iterates through
on a list called `SDL2_DLLS` and copies every item to a different folder:

```cmake
foreach(dll ${SDL2_DLLS})
    file(COPY ${dll} DESTINATION ${CMAKE_CURRENT_BINARY_DIR})
endforeach()
```

### Include

An important command is the `include_directories`. You can specify
paths as parameterand it means that you can include the header files
from that path.

For example this line makes it possible that we can include the SDL
header files:
`include_directories(${SDL2_INCLUDE_DIR} ${SDL2_IMAGE_INCLUDE_DIR} ${SDL2_TTF_INCLUDE_DIR})`

### Create executable

You can create an executable file the ```add_executable``` command.
The first argument will be the name of the executable.
The other arguments should be files which will be compiled into that executable.
For example:

`add_executable(wanderer main.cpp resource.cpp hero.cpp ${gfx_inc} ${gfx_src})`

To link other libraries to your executable you need to use the
`target_link_libraries` command:

`target_link_libraries(wanderer ${SDL2_LIBRARY} ${SDL2_IMAGE_LIBRARIES} ${SDL2_TTF_LIBRARIES})`

### More executables

In a single project you can create more executables and then you can choose
which one to run next to the run button in CLion.
The way you do this is to add more `add_executable` lines in your
CMake files.
This is how it looks like in the multiple executables SDL setup:

```cmake
foreach(executable ${EXECUTABLES})
    add_executable(${executable} main.cpp ${executable}.cpp ${gfx_inc} ${gfx_src})
    target_link_libraries(${executable} ${SDL2_LIBRARY} ${SDL2_IMAGE_LIBRARIES} ${SDL2_TTF_LIBRARIES})
endforeach()
```

## SDL CMake files

The [FindSDL2_image.cmake](resource/FindSDL2_image.cmake),
[FindSDL2_ttf.cmake](resource/FindSDL2_ttf.cmake), [FindSDL2_all_multiple_executables.cmake](resource/FindSDL2_all_multiple_executables.cmake)
files are downloaded from [here](https://github.com/tcbrindle/sdl2-cmake-scripts).

These CMake files are responsible to locate the SDL files, set some variables,
set additional compiler flags, etc..
It also manages the differences on different operating systems.
These files are executed with these commands:

```cmake
find_package(SDL2 REQUIRED)
find_package(SDL2_image REQUIRED)
find_package(SDL2_ttf REQUIRED)
```
