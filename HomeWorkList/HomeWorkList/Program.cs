﻿using HomeWorkList;

var mpList = new MPList<int>();
mpList.AddItem(100);
mpList.AddItem(200);
mpList.AddItem(200);
mpList.AddItem(200);
mpList.AddItem(200);
mpList.DeleteItem(0);
var i = mpList.GetItem(0);
Console.WriteLine(i);
mpList.AddItem(300);
mpList.UpdateItem(0, 500);
var b = mpList.GetItem(0);
Console.WriteLine(b);
Console.WriteLine(mpList[3]);
mpList[3] = 999;
Console.WriteLine(mpList[3]);
Console.WriteLine($"Count: {mpList.Count}");

var secondMpList = new MPList<int>();
secondMpList.AddItem(333);
secondMpList.AddItem(444);
secondMpList.AddItem(555);

var thirdMpList = mpList + secondMpList;
Console.WriteLine(thirdMpList[0]);
Console.WriteLine(thirdMpList[thirdMpList.Count]);