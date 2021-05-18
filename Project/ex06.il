.assembly ex06 {}
.assembly extern mscorlib {}

.class Program
{
    .method public instance void foo() cil managed
    {
        ldstr "foo"
        call void [mscorlib]System.Console::WriteLine(string)
        ret
    }

    .method public specialname rtspecialname instance void .ctor() cil managed
    {
        //  기반 클래스 생성자 호출
        ldstr "foo"
        call instance void [mscorlib]System.Object::L.ctor()
        
        ret
    }

    .method public static void Main() cil managed
    {
        .entrypoint

        .locals init( class Program V_0 )

        newobj instance void Program::.ctor()

        stloc.0

        ldloc.0
        callvirt instance void Program::foo() // callvirt는 객체를 호출하는 명령어
        
        ret
    }
}
