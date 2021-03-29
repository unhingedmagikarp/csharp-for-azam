# SDL2 single executable environment setup

This environment setup guide shows you how to setup a project for a single big
project like Wanderer

## Windows

1. Download the SDL2 files for [Windows](resource/SDL2_windows.zip)
1. Unzip the downloaded file to a directory e.g. `C:/SDL2-2.0.8`
1. Create a new C++ Executable project in CLion
1. Create a new directory called `cmake` and put the following files there
   - [FindSDL2.cmake](resource/FindSDL2.cmake)
   - [FindSDL2_image.cmake](resource/FindSDL2_image.cmake)
   - [FindSDL2_ttf.cmake](resource/FindSDL2_ttf.cmake)
   - [FindSDL2_all.cmake](resource/FindSDL2_all_single_executable.cmake)
1. Replace your `main.cpp` with [this one](resource/main_single_executable.cpp)
1. Modify your `CMakeLists.txt` according to the following
   - Remove the `add_executable` line
   - Insert the following

     ```raw
     set(SDL2_ROOT_PATH C:/SDL2-2.0.8)

     IF(WIN32)
         set(MINGW_VERSION i686-w64-mingw32)
     ENDIF()

     set(CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/cmake)

     find_package(SDL2_all REQUIRED)
     ```

   - You might need to change the value of `SDL2_ROOT_PATH`
     - It should be the path where you unzipped the SDL2 files
   - If you have 64 bit MinGW change the `MINGW_VERSION` to `x86_64-w64-mingw32`
1. Reset Cache and Reload Project (Tools -> CMake)

## macOS

1. Download the SDL2 files for [macOS](resource/SDL2_macOS.zip)
1. Open all `dmg` files and copy the `.framework` files to `/Library/Frameworks`
1. Copy the `SDL2_plugins` directory from the downloaded zip file to a directory
   e.g. `/usr/local`
1. Create a new C++ Executable project in CLion
1. Create a new directory called `cmake` and put the following files there with
   the exact same filename
   - [FindSDL2.cmake](resource/FindSDL2.cmake)
   - [FindSDL2_image.cmake](resource/FindSDL2_image.cmake)
   - [FindSDL2_ttf.cmake](resource/FindSDL2_ttf.cmake)
   - [FindSDL2_all.cmake](resource/FindSDL2_all_single_executable.cmake)
1. Replace your `main.cpp` with [this one](resource/main_single_executable.cpp)
1. Modify your `CMakeLists.txt` according to the following
   - Remove the `add_executable` line
   - Insert the following

     ```raw
     set(SDL2_ROOT_PATH /usr/local)

     set(CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/cmake)

     find_package(GFA_SDL2 REQUIRED)
     ```

   - You might need to change the value of `SDL2_ROOT_PATH`
     - It should be the path where you copied the `SDL2_plugins`
1. Reset Cache and Reload Project (Tools -> CMake)

## How to use it

You should add every new .cpp files to the ```add_executable``` command as
parameter like this:

```cmake
add_executable(wanderer main.cpp ${gfx_inc} ${gfx_src} ../Grid.cpp ../Grid.h)
```

If you tick the ```Add to Targets``` checkbox when you create a new file it will
happen automatically.
