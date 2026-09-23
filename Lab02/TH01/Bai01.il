
//  .NET IL Disassembler.  Version 10.0.12


// warning : THIS IS A PARTIAL DISASSEMBLY, NOT SUITABLE FOR RE-ASSEMBLING



.class private abstract auto ansi sealed beforefieldinit Bai01
       extends [System.Runtime]System.Object
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 01 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = ( 01 00 00 00 00 ) 
  .method private hidebysig static string 
          NhapHoTen() cil managed
  {
    // Code size       16 (0x10)
    .maxstack  8
    IL_0000:  ldstr      "Nhap ho ten: "
    IL_0005:  call       void [System.Console]System.Console::Write(string)
    IL_000a:  call       string [System.Console]System.Console::ReadLine()
    IL_000f:  ret
  } // end of method Bai01::NhapHoTen

  .method private hidebysig static void  XuatHoTen(string hoTen) cil managed
  {
    // Code size       17 (0x11)
    .maxstack  8
    IL_0000:  ldstr      "Ho ten ban vua nhap: "
    IL_0005:  ldarg.0
    IL_0006:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_000b:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0010:  ret
  } // end of method Bai01::XuatHoTen

  .method public hidebysig static void  xuly() cil managed
  {
    // Code size       11 (0xb)
    .maxstack  8
    IL_0000:  call       string Bai01::NhapHoTen()
    IL_0005:  call       void Bai01::XuatHoTen(string)
    IL_000a:  ret
  } // end of method Bai01::xuly

} // end of class Bai01

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file Bai01.res
