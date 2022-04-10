using System;

string BasicInformation="name";
Console.WriteLine("name:");
string name =Console.ReadLine();

string BasicInformation2="gender 1.boy 2.girl";
Console.WriteLine("gender 1.boy 2.girl:");
string gender =Console.ReadLine();
switch (gender)
{
    case "1":
        Console.WriteLine("boy");
        break;

    case "2":
        Console.WriteLine("girl");
        break;

    default:
        Console.WriteLine("tks");
        break;
}

string basicInformation3="birthday";
Console.WriteLine("yyyy/mm/dd:");
string bir =Console.ReadLine();

string basicInformation4="ID";
Console.WriteLine("ID:");
string ID =Console.ReadLine();

show:
Console.WriteLine(name);
Console.WriteLine(gender);
Console.WriteLine(bir);
Console.WriteLine(ID);


Console.WriteLine("1.correct 2.fill in again:");
int intyn = Convert.ToInt32(Console.ReadLine());
if (intyn ==1)
{
    Console.WriteLine("已完成資料建置");
}

else if(intyn ==2)
{
    Console.WriteLine("which one do you want to fill in again?\nname,gender,bir,ID?");
    string fill = Console.ReadLine();
        switch (fill)
        {
            case "name":
                  name=Console.ReadLine();
                  goto show;
            case "gender":
                  gender=Console.ReadLine();
                  goto show;
            case "bir":
                  bir=Console.ReadLine();
                  goto show;
            case "ID":
                  ID=Console.ReadLine();
                  goto show;
        }
    
}
else
{
    Console.WriteLine("?-?");
}


        