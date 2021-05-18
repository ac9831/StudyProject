### C# 언어와 IL

C/C++은 특정 환경(인텔 CPU, Windows OS)에서만 실행 가능
C#은 C# 컴파일러를 통해 실행 가능한 파일을 만든다. 이 파일은 CPU와 OS에 독립적인 기계어 코드다.
중간 언어(Intermediate Language) -> C#을 컴파일러 해서 나오는 언어
IL 언어를 알 수 있으면 C# 문법에 대해 깊이 있게 알 수 있다.

### IL 파일

IL은 파일 확장자가 .il 이다.
.entrypoint는 method에 하나만 존재해야 한다.

IL 파일을 빌드하는 명령어
ilasm filename.il

exe파일을 IL 파일로 배포하는 방법
ildasm sample.exe => IL DSAM 이 실행된다.
ildasm sample.exe /out=a.txt => a.txt로 IL 코드가 생성된다.

csc test.cs // 코드 컴파일, exe 파일 빌드

### 연산자 재정의 함수의 원리

C# Operator+ => IL op_Addition으로 변환 된다.
연산자 재정의, Property, Indexer는 IL에서는 약속된 이름의 메소드로 변환된다.
단, op_Addition을 직접 만들면 에러난다. 왜냐하면 Operator+로 선언한 것이 IL에서 specialname 이름이 붙은 메서드로 변환되기 때문이다.

### MakeiIl Batch 파일

@csc %1
$ildasm /out=%~n1.il %~n1.exe
@del %~n1.exe
@del %~n1.res
