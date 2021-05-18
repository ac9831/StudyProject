.assembly ex02 {}

.method static void foo() cil managed
{
    .entrypoint

    call void goo()

    ldc.i4.1 // push 1, il 명령어 찾아서 한번 볼 것. 스택에 4바이트짜리 형식에 1을 넣어라란 뜻이다.
    ldc.i4.2 // push 2

    call void hoo(int32, a, int32 b)
    ret
}


.method static void hoo() cil managed
{
    ret
}

.method static void goo() cil managed
{
    ret
}