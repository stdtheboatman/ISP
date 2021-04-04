#pragma once

#ifdef MYLIB_EXPORTS
#define MYLIB_API __declspec(dllexport)
#else
#define MYLIB_API __declspec(dllimport)
#endif

//extern "C" MYLIBDLL_API void hello();

extern "C" MYLIB_API int _stdcall Min(int a, int b);

extern "C" MYLIB_API int _stdcall Max(int a, int b);

extern "C" MYLIB_API int _cdecl Pow(int a, int n);

extern "C" MYLIB_API int _cdecl Gcd(int a, int b);
