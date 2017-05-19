using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public class cHelloWorld
{
    [SqlFunction]
    public static SqlString HelloWorld()
    {
        return ("Hello");
    }
}
create function dbo.Hello() returns nvarchar(128)
external name HelloWorld.cHelloWorld.Hello