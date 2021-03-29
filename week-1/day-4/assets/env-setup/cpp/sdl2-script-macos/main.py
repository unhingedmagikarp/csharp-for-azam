#!/usr/bin/python3

import shutil
import os
import sys
import argparse

def copy_files(files, *destination):
    for file in files:
        shutil.copy(file, os.path.join(*destination))

def create_folder(folder_name, destination):
    try:
        os.mkdir(os.path.join(destination, folder_name))
    except FileExistsError:
        print(f'[INFO] {os.path.join(destination, folder_name)} already exists')

if __name__ == '__main__':

    parser = argparse.ArgumentParser()
    parser.add_argument('-s', '--single', action='store_true', help='Single executable project like Wanderer')
    parser.add_argument('-m', '--multiple', action='store_true', help='Multiple executables like Drawing workshop')
    parser.add_argument("path")
    args = parser.parse_args()
    
    if not (args.single or args.multiple):
      parser.error('No action requested, add --single or --multiple')

    if not args.path:
        print(f'[ERROR] missing path')
        sys.exit(1)

    if not os.path.isabs(args.path):
        print(f'[ERROR] provided argument is not an absolute path')
        sys.exit(1)

    cmake_files = [
        'cmake/FindSDL2_image.cmake',
        'cmake/FindSDL2_ttf.cmake',
        'cmake/FindSDL2.cmake'
    ]

    boilerplate_files = []
    
    if args.single:
      cmake_files.append('cmake/FindSDL2_all_single_executable.cmake')
      boilerplate_files.append('main_single_executable.cpp')
    elif args.multiple:
      cmake_files.append('cmake/FindSDL2_all_multiple_executables.cmake')
      boilerplate_files.append('main_multiple_executables.cpp')
      boilerplate_files.append('draw.cpp')
      boilerplate_files.append('draw.h')

    project_abs_path = args.path
    CMAKE_FOLDER = 'cmake'

    create_folder(CMAKE_FOLDER, project_abs_path)
    copy_files(cmake_files, project_abs_path, CMAKE_FOLDER)
    copy_files(boilerplate_files, project_abs_path)
    
    if args.single:
        shutil.move(os.path.join(project_abs_path, CMAKE_FOLDER, 'FindSDL2_all_single_executable.cmake'),
                    os.path.join(project_abs_path, CMAKE_FOLDER, 'FindSDL2_all.cmake'))
                    
        shutil.move(os.path.join(project_abs_path, 'main_single_executable.cpp'),
                    os.path.join(project_abs_path, 'main.cpp'))
    elif args.multiple:
        shutil.move(os.path.join(project_abs_path, CMAKE_FOLDER, 'FindSDL2_all_multiple_executables.cmake'),
                    os.path.join(project_abs_path, CMAKE_FOLDER, 'FindSDL2_all.cmake'))
                    
        shutil.move(os.path.join(project_abs_path, 'main_multiple_executables.cpp'),
                    os.path.join(project_abs_path, 'main.cpp'))

    CMakeLists_content = None
    with open(os.path.join(project_abs_path, 'CMakeLists.txt'), 'r') as f:
        CMakeLists_content = f.readlines()
        CMakeLists_content = list(filter(lambda x: not x.startswith('add_executable'), CMakeLists_content))

    if args.single:
        CMakeLists_extension = '''
set(SDL2_ROOT_PATH /usr/local)

set(CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/cmake)

IF(WIN32)
    set(MINGW_VERSION i686-w64-mingw32)
ENDIF()

find_package(SDL2_all REQUIRED)
'''
    elif args.multiple:
        CMakeLists_extension = '''
set(SDL2_ROOT_PATH /usr/local)

set(EXECUTABLES "draw")
set(CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/cmake)

IF(WIN32)
    set(MINGW_VERSION i686-w64-mingw32)
ENDIF()

find_package(SDL2_all REQUIRED)
'''

    with open(os.path.join(project_abs_path, 'CMakeLists.txt'), 'w') as f:
        f.writelines(CMakeLists_content)
        f.writelines(CMakeLists_extension)

    print(f'[INFO] The project is ready to use SDL2')
