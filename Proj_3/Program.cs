int v=0;
string r;

Console.WriteLine("Välkommen till Random Frågor, en simpel frågesport med lite random skit.");
Console.WriteLine("Var snäll och skriv in bokstaven av svaret du tror är rätt, annars avslutas spelet");
Console.WriteLine("Förstår du?");
Console.WriteLine("a)Ja b)Nej c)Självklart, nu kör vi!");
r = Console.ReadLine().ToLower();

if(r=="a"){
    Console.WriteLine("Bra, då kör vi.");
}
else if(r=="b"){
    Console.WriteLine("Du verkar ha förståt tho??");
    Console.WriteLine("Vi kör ändå");
}
else if(r=="c"){
    Console.WriteLine("Älskar din entusiasm, LETS GOOO!!");
}
else{
    Console.WriteLine("Är du dum eller???");
    Console.WriteLine("Skriv in ett av de givna svaren nästa gång!");
}

/*----------------------------------------------------------------------------------------*/
/*Frågorna*/


if (r=="a"||r=="b"||r=="c"){
    Console.WriteLine("Vem är skaparen av detta spelet?");
    Console.WriteLine("a)Sverre b)Maximiliam c)Sam");
    r=Console.ReadLine().ToLower();
    if(r=="b"){
        v++;
    }
    

    if(r=="a"||r=="b"||r=="c"){
        Console.WriteLine("Vad är namnet på en oordnad lista i HTML?");
        Console.WriteLine("a)ul b)ol c)hl");
        r=Console.ReadLine().ToLower();
        if(r=="a"){
            v++;
        }


        if(r=="a"||r=="b"||r=="c"){
            Console.WriteLine("Vem är den sämsta läraren på skolan?");
            Console.WriteLine("a)Kalle b)Mikael c)Vera");
            r=Console.ReadLine().ToLower();
            if(r=="a"||r=="c"){
                v++;
            }


            if(r=="a"||r=="b"||r=="c"){
                Console.WriteLine("Vem är bästa läraren på skolan?");
                Console.WriteLine("a)Jesus Skinberg b)Mikael c)Ulf");
                r=Console.ReadLine().ToLower();
                if(r=="a"||r=="b"){
                    v++;
                }


                if(r=="a"||r=="b"||r=="c"){
                    if(v<=1){
                        Console.WriteLine("Du fick "+v+" rätt, fan va skit.");
                    }
                    if(v>=3){
                        Console.WriteLine("Grattis! Du fick "+v+" rätt, bra jobbat");
                    }
                }

/*----------------------------------------------------------------------------------------*/
/*Fail safe*/

                else{
                    Console.WriteLine("Är du dum eller???");
                    Console.WriteLine("Skriv in ett av de givna svaren nästa gång!");
                    }
            }
            else{
                Console.WriteLine("Är du dum eller???");
                Console.WriteLine("Skriv in ett av de givna svaren nästa gång!");
                }
        }
        else{
            Console.WriteLine("Är du dum eller???");
            Console.WriteLine("Skriv in ett av de givna svaren nästa gång!");
            }
    }
    else{
        Console.WriteLine("Är du dum eller???");
        Console.WriteLine("Skriv in ett av de givna svaren nästa gång!");
        }
    
}
else{
    Console.WriteLine("Är du dum eller???");
    Console.WriteLine("Skriv in ett av de givna svaren nästa gång!");
}

Console.ReadLine();