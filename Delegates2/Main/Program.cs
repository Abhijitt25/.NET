using bookrecord;
using ackDeligate;
using acknowledge;

Books b=new Books();

b.NoOfCopies=5;
b.borrow("Thremodynamics","Physics",4);


Acknowledge a=new Acknowledge();
AckDeligates sd=new AckDeligates(a.msg);
b.msg+=a.msg;
b.NoOfCopies=4;
b.borrow("RDSHARMA","Maths",6);