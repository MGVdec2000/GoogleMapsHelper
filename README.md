# GoogleMapsHelper
Static C# Helper Class for Generating Static Google Maps Urls

```GoogleMapsHelper.PathString()``` creates a pipe delimited Latitue and Longitude string from a ```List``` of ```PositionModel```.

```GoogleMapsHelper.EncodePolyLine()``` works the same as ```PathString()``` but returns an [encoded polyline](https://developers.google.com/maps/documentation/utilities/polylinealgorithm).

The optional ```skip``` parameter reduces the number of points used to generate the URL. The maximum URL length is 8192 characters. The default value of 0, uses all points in the list of ```PositionModel```.

## Examples
Taken from [https://developers.google.com/maps/documentation/utilities/polylinealgorithm](https://developers.google.com/maps/documentation/utilities/polylinealgorithm)

```
List<PositionModel> positions = new();
positions.Add(new PositionModel(38.5, -120.2, 10));
positions.Add(new PositionModel(40.7, -120.95, 10));
positions.Add(new PositionModel(43.252, -126.453, 10));
```

### Path
```
string line = GoogleMapsHelpers.PathString(positions);
Assert.Equal(@"&path=38.5000,-120.2000|40.7000,-120.9500|43.2520,-126.4530", line);
```

### Encoded Polyline
```
string line = GoogleMapsHelpers.EncodePolyLine(positions);
Assert.Equal(@"&path=enc:_p~iF~ps|U_ulLnnqC_mqNvxq`@", line);
```
