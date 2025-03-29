# Simple Safe Area

A simple Safe Area script.

Add it as a component to a GameObject that is child to the root Canvas. It will restrict itself to the Safe Area upon Play.

To be affected from the Safe Area GameObject, children should be anchored to its borders.

This script only works on Play mode.

### Installation

1. Open the Package Manager from Window > Package Manager.
2. Click the "+" button > Add package from git URL.
3. Enter the following URL:

```
https://github.com/konsnos/Simple-Safe-Area.git?path=Assets/SimpleSafeArea
```

Alternatively, open Packages/manifest.json and add the following to the dependencies block:

```json
{
    "dependencies": {
        "com.konsnos.simplesafearea": "https://github.com/konsnos/Simple-Safe-Area.git?path=Assets/SimpleSafeArea"
    }
}
```