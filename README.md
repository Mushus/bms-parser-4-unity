# bms-parser

BMS parser written in C#

## Install

### Unity 2019.3

1. Press `Window > Package Manager` on the menu bar to open the `Package Manager` window.
1. Press the `+` button and select the `Add package from git URL...` from the menu that appears.
1. Enter `git@github.com:Mushus/bms-parser-4-unity.git#[version]` in the input form that appears and press the `OK` button.
1. `[Version]` is the version number that you want to use. ex. `v1.0.0`

## Usage

```
var s = File.Open("test.bms", FileMode.Open);
var parser = new BMS.Parser();
var bms = parser.Parse(s);

Console.WriteLine(bms.Title); // show title
Console.WriteLine(bms.Timeline.Event); // show event data
```

## TODO:

```
git subtree split --prefix=Assets/RotateMe --branch upm
```
