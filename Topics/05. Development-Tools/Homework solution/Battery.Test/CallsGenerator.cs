
using System;
using MobilePhones;

class CallsGenerator
        {
        		private DateTime refDate = new DateTime(2000, 1, 1);
		private Call[] calls=new Call[50];
		public CallsGenerator(){
                        calls[0]=  new Call(refDate.AddTicks(453439430000000), "045569329", 816);
                          calls[1]=  new Call(refDate.AddTicks(-808674670000000), "035720330", 2696);
                          calls[2]=  new Call(refDate.AddTicks(201458570000000), "047242923", 1571);
                          calls[3]=  new Call(refDate.AddTicks(25942210000000), "011572006", 2245);
                          calls[4]=  new Call(refDate.AddTicks(-565462240000000), "046229525", 2896);
                          calls[5]=  new Call(refDate.AddTicks(-677531690000000), "018400713", 2213);
                          calls[6]=  new Call(refDate.AddTicks(-807580010000000), "050156007", 812);
                          calls[7]=  new Call(refDate.AddTicks(675020370000000), "076061469", 1145);
                          calls[8]=  new Call(refDate.AddTicks(-863115030000000), "053769254", 485);
                          calls[9]=  new Call(refDate.AddTicks(-571758060000000), "061571602", 3055);
                          calls[10]=  new Call(refDate.AddTicks(-10345790000000), "012553028", 1467);
                          calls[11]=  new Call(refDate.AddTicks(743727870000000), "041058024", 231);
                          calls[12]=  new Call(refDate.AddTicks(515936040000000), "091956557", 2637);
                          calls[13]=  new Call(refDate.AddTicks(761032430000000), "096123636", 1404);
                          calls[14]=  new Call(refDate.AddTicks(497533520000000), "073281963", 3105);
                          calls[15]=  new Call(refDate.AddTicks(-483776780000000), "083658811", 1538);
                          calls[16]=  new Call(refDate.AddTicks(-145970910000000), "091250833", 3160);
                          calls[17]=  new Call(refDate.AddTicks(515399710000000), "080387682", 1141);
                          calls[18]=  new Call(refDate.AddTicks(-126673140000000), "087788180", 2562);
                          calls[19]=  new Call(refDate.AddTicks(794089940000000), "083319098", 376);
                          calls[20]=  new Call(refDate.AddTicks(833333540000000), "072304100", 1051);
                          calls[21]=  new Call(refDate.AddTicks(364404070000000), "084842744", 2969);
                          calls[22]=  new Call(refDate.AddTicks(42226140000000), "028905481", 1530);
                          calls[23]=  new Call(refDate.AddTicks(-383071760000000), "097337031", 1015);
                          calls[24]=  new Call(refDate.AddTicks(-90173970000000), "041806691", 2564);
                          calls[25]=  new Call(refDate.AddTicks(222309680000000), "023333007", 1350);
                          calls[26]=  new Call(refDate.AddTicks(-387150380000000), "032239369", 3469);
                          calls[27]=  new Call(refDate.AddTicks(-812643320000000), "066704531", 3450);
                          calls[28]=  new Call(refDate.AddTicks(-443991830000000), "058138477", 458);
                          calls[29]=  new Call(refDate.AddTicks(-814840290000000), "073360569", 35);
                          calls[30]=  new Call(refDate.AddTicks(674980570000000), "078838522", 1785);
                          calls[31]=  new Call(refDate.AddTicks(-90440660000000), "029371224", 903);
                          calls[32]=  new Call(refDate.AddTicks(-141428310000000), "020132312", 1907);
                          calls[33]=  new Call(refDate.AddTicks(-335194070000000), "038257806", 845);
                          calls[34]=  new Call(refDate.AddTicks(-533311720000000), "027080155", 687);
                          calls[35]=  new Call(refDate.AddTicks(-549675110000000), "034769061", 37);
                          calls[36]=  new Call(refDate.AddTicks(12372050000000), "093993139", 1083);
                          calls[37]=  new Call(refDate.AddTicks(533264180000000), "015361426", 659);
                          calls[38]=  new Call(refDate.AddTicks(-310362590000000), "026825615", 2276);
                          calls[39]=  new Call(refDate.AddTicks(-788079470000000), "084451881", 73);
                          calls[40]=  new Call(refDate.AddTicks(-329718870000000), "078682616", 1266);
                          calls[41]=  new Call(refDate.AddTicks(861158650000000), "071146850", 2753);
                          calls[42]=  new Call(refDate.AddTicks(-606919360000000), "013946919", 458);
                          calls[43]=  new Call(refDate.AddTicks(294756360000000), "052429793", 1354);
                          calls[44]=  new Call(refDate.AddTicks(266783760000000), "088992785", 1368);
                          calls[45]=  new Call(refDate.AddTicks(711270380000000), "046720396", 1889);
                          calls[46]=  new Call(refDate.AddTicks(594950720000000), "068911859", 1073);
                          calls[47]=  new Call(refDate.AddTicks(686200240000000), "026647923", 2067);
                          calls[48]=  new Call(refDate.AddTicks(5358460000000), "091621171", 2406);
                          calls[49]=  new Call(refDate.AddTicks(299877450000000), "031499742", 3483);
          		}

			public Call[] Calls
			{
				get
				{
					return (Call[])calls.Clone();
				}
			}
        }
    