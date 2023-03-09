Console.Clear();
Console.Write("total task\n\n");

int i;

void print_array(ref string[] array){
    Console.Write("[");
    for (i = 0; i < array.Length; i++){
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write("\b\b]\n");
}

Console.Write("input strings separated by enter\ndouble enter stops input:\n");
string sourceTxt = string.Empty;
string addedLine = string.Empty;
while (addedLine != "\n"){
    sourceTxt += addedLine;
    addedLine = Console.ReadLine() + "\n";
}

string[] strings = sourceTxt.Split("\n");

int amt3Chars = 0;
for (i = 0; i < strings.Length; i++){
    if (strings[i].Length > 0 && strings[i].Length < 4){
        amt3Chars += 1;
    }
}

if (amt3Chars > 0){
    string[] strings3Chars = new string[amt3Chars];
    int j = 0;
    for (i = 0; i < strings.Length; i++){
        if (strings[i].Length > 0 && strings[i].Length < 4){
            strings3Chars[j] = strings[i];
            j += 1;
        }
    }
    print_array(ref strings3Chars);
}
else {
    Console.Write("no lines less than 4 chars");
}