# SDL2 multiple executables environment setup

This environment setup guide shows you how to setup a project for multiple
little exercises like the Drawing workshop

## Windows

1. Download the SDL2 files for [Windows](resource/SDL2_windows.zip)
1. Unzip the downloaded file to a directory e.g. `C:/SDL2-2.0.8`
1. Create a new C++ Executable project in CLion
1. Create a new directory called `cmake` and put the following files there
   - [FindSDL2.cmake](resource/FindSDL2.cmake)
   - [FindSDL2_image.cmake](resource/FindSDL2_image.cmake)
   - [FindSDL2_ttf.cmake](resource/FindSDL2_ttf.cmake)
   - [FindSDL2_all.cmake](resource/FindSDL2_all_multiple_executables.cmake)
1. Replace your `main.cpp` with [this one](resource/main_multiple_executables.cpp)
1. Put this [`draw.h`](resource/draw.h) next to your `main.cpp`
1. Modify your `CMakeLists.txt` according to the following
   - Remove the `add_executable` line
   - Insert the following

     ```raw
     set(SDL2_ROOT_PATH C:/SDL2-2.0.8)

     IF(WIN32)
         set(MINGW_VERSION i686-w64-mingw32)
     ENDIF()

     set(EXECUTABLES "")
     set(CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/cmake)

     find_package(GFA_SDL2 REQUIRED)
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
   - [FindSDL2_all.cmake](resource/FindSDL2_all_multiple_executables.cmake)
1. Replace your `main.cpp` with [this one](resource/main_multiple_executables.cpp)
1. Put this [`draw.h`](resource/draw.h) next to your `main.cpp`
1. Modify your `CMakeLists.txt` according to the following
   - Remove the `add_executable` line
   - Insert the following

     ```raw
     set(SDL2_ROOT_PATH /usr/local)

     set(EXECUTABLES "")
     set(CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/cmake)

     find_package(GFA_SDL2 REQUIRED)
     ```

   - You might need to change the value of `SDL2_ROOT_PATH`
     - It should be the path where you copied the `SDL2_plugins`
1. Reset Cache and Reload Project (Tools -> CMake)

## How to use it

1. Create a `.cpp` file without a header e.g. `draw.cpp`

**IMPORTANT:** Make sure that the ```Add to Targets``` checkbox is unchecked
when you create the new file, otherwise it will be added multiple times which
leads to linker error.

1. Add the following boilerplate code to it

   ```cpp
    #include "draw.h"

    void draw(SDL_Renderer* gRenderer) {
    }
   ```

1. Add the filename without extension to the `EXECUTABLES` variable in the
   `CMakeLists.txt` file
   - Separated by semicolons e.g. `set(EXECUTABLES "draw;draw2;draw3")`
1. Reload changes
