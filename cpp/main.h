#pragma once

#ifndef PINVOKE_HEADER
#define PINVOKE_HEADER

#include <stdint.h>
#include <stdlib.h>

#ifdef CPP_EXPORTS
#define LIBRARY_API __declspec(dllexport)
#else
#define LIBRARY_API __declspec(dllimport)
#endif

extern "C" LIBRARY_API int initialPos(int h, int w, int *map, int* ret);

#endif
