cmake_minimum_required(VERSION 3.20)
project(Lab5)

set(CMAKE_CXX_STANDARD 14)

include_directories(ConsoleApplication1)

add_executable(Lab5
        ConsoleApplication1/ConsoleApplication1.cpp
        ConsoleApplication1/Data.cpp
        ConsoleApplication1/Data.h
        ConsoleApplication1/F1.cpp
        ConsoleApplication1/F1.h
        ConsoleApplication1/F2.cpp
        ConsoleApplication1/F2.h
        ConsoleApplication1/F3.cpp
        ConsoleApplication1/F3.h
        ConsoleApplication1/Header.h
        ConsoleApplication1/Lab4.cpp
        ConsoleApplication1/Lab4.h)
