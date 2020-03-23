# bms-parser

BMS parser written in C#

## Install

### Unity

Follow the example below to add it to the `Packages/manifest.json` file.

```manifest.json
{
  "dependencies": {
    "net.mushus.bms-parser-4-unity": "https://github.com/Mushus/bms-parser-4-unity.git"
  }
}
```

## Usage

```
var s = File.Open("test.bms", FileMode.Open);
var parser = new Parser();
var bms = parser.Parse(s);

Console.WriteLine(bms.Title); // show title
Console.WriteLine(bms.Timeline.Event); // show event data
```
