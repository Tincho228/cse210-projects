using System;
using System.Net;
using System.Text.Json.Nodes;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Sandbox World!");
        
        API api = new API();
        await api.GetJson();
        string source = api.GetResponse();
        Console.Clear();
        for(int i =0; i<10 ;i++)
        {
            Console.WriteLine(i);
        }
        string str = source;
        int start;
        int at;
        int end;
        int count;

        end = str.Length;
        start = 0;
        Console.WriteLine();
        Console.Write("The string 'dt' occurs at position(s): ");

        count = 0;
        at = 0;
        List<int> numeros = new List<int>();
        List<string> dts = new List<string>();
        while((start <= end) && (at > -1))
        {
            // start+count must be a position within -str-.
            count = end - start;
            at = str.IndexOf("\"dt\"", start, count);
            if (at == -1) break;
            Console.Write("{0} ", at);
            numeros.Add(at);
            start = at+1;
        }
        int oldNumber = numeros[0];
        for(int i = 1; i < numeros.Count()-1; i++)
        { 
            dts.Add(source.Substring(oldNumber,numeros[i]-oldNumber-2));
            oldNumber = numeros[i];   
        }
        Console.WriteLine();
        string day = dts[0];
        string[] items = {"\"main\"","\"humidity\"","\"weather\"","\"clouds\"","\"wind\"","\"visibility\"","\"pop\"","\"sys\"","\"dt_txt\""};
        Console.WriteLine(dts[0]);
        oldNumber = 0;
        for(int i = 0; i<items.Length; i++)
        {
            int at_item = dts[0].IndexOf(items[i]);
            Console.Write(at_item + " ");
            Console.WriteLine(dts[0].Substring(oldNumber, at_item - oldNumber));
            oldNumber = at_item;
        }
    }   
}