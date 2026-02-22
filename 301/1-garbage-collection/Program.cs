/* GARBAGE COLLECTION happens automatically!
 * 
 * Manual processes:
 * 1. OS Resources:
 *   a. Files,
 *   b. network connections.
 */

using System;

void SomeBigProcess()
{
  var byteArr = new byte[1000000];

  // forceFullCollection as false
  Console.WriteLine($"Memory allocated INSIDE: {GC.GetTotalMemory(false):N}");
  Console.ReadLine();
}

Console.WriteLine($"Memory allocated BEFORE: {GC.GetTotalMemory(false):N}");
Console.ReadLine();

SomeBigProcess();

GC.Collect();

Console.WriteLine($"Memory allocated AFTER collection: {GC.GetTotalMemory(false):N}");
Console.ReadLine();
