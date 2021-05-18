.assembly ex04 {}
.assembly extern mscorlib {}

.method public static void foo() cil managed
{
    .entrypoint

    .locals init(int32 V_0, int32 V_1)

    ldc.i4.2 // push 2
    stloc.0 // x = 2

    ldc.i4.s 20 // push 20
    stloc.1 // y = 20

    ldstr "{0}, {1}"
    ldloc.0
    box   int32

    ldloc.1
    box   int32

    call void [mscorlib] System.Console::WriteLine(string, object, object)

    ret
}