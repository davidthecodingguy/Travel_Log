﻿using System;
using System.Drawing;
namespace The_Daily_Travel_Log
{
    public class ProgramLogo
    {
        public static void WriteLogo()
        {
            string logo = @"
_______
|_   _| __  __ ____                                              ___ ____ 
  | |   ||__|| | _|                                              \\ \\  // 
  | |   ||__|| | _|                                               \\ \\// 
  |_|   ||  || |  |                                               // //\\ 
 ____                                                            //_//__\\
|  _  \        __ || _  _                                          .
| | | |   /\   || || \\//                                        .
| |_| |  /  \  || ||  ||                                       .
|____ / / /\ \ || ||  ||                                       .
_______                                                        .
|_   _| ___               ____ ||                              .
  | |  |   \   /\  \ \/ / | _| ||                        . . . . . . . . . . . . 
  | |  |   /  /  \  \  /  | _| ||                      .       .                . 
  |_|  |/\ \ / /\ \  \/   |  | ||                    .         .                 .
___                                                .           .                  .
| |                  _____                       .             .                   .
| |         ___     //  \_\                    .               .                    .
| |       /  _  \  ||   ___  . . . . . . . . .                 . . . . . . . . . . . .
| |_____ |  |_|  | \\  |__ | 
|_|_____| \     /   \\    /  
                             
            ";
            Console.WriteLine(logo, Color.Green);
        }
    }
}