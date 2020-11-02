# C# P/Invoke 샘플

(작성중입니다)

## 실행 방법
1. Visual Studio로 레포의 솔루션을 실행합니다. cpp, csharp 두 개의 프로젝트가 있습니다. cpp는 dll 파일을 만들고, csharp는 그 dll 파일을 사용합니다.
2. cpp, csharp 프로젝트를 각각 빌드합니다. 이 때 반드시 cpp와 csharp은 같은 아키텍쳐를 대상으로 컴파일되어야 합니다! 저는 x64로 컴파일했습니다.
3. 컴파일 된 dll 파일을 csharp 프로젝트에서 만들어지는 exe 파일과 같은 폴더로 복사합니다.

## 주요 파일
- [C#] [`InitialPosAdapter.cs`](https://github.com/jungnoh/pinvoke-sample/blob/main/csharp/InitialPosAdapter.cs): P/Invoke 및 marshalling이 이루어집니다.
- [C++] [`main.cpp`](https://github.com/jungnoh/pinvoke-sample/blob/main/cpp/main.cpp): Export할 함수의 구현체입니다.
- [C++] [`main.h`](https://github.com/jungnoh/pinvoke-sample/blob/main/cpp/main.h): Export할 함수 및 dllexport 정의가 작성되어 있습니다.

## Reference
- [P/Invoke Tutorial](https://manski.net/2012/06/pinvoke-tutorial-passing-parameters-part-3/)
- [Marshaling MS 문서](https://docs.microsoft.com/en-us/dotnet/framework/interop/marshaling-different-types-of-arrays)

## License
MIT