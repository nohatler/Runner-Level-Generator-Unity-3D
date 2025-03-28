## Runner Level Generator Unity 3D
#### This simple asset will help you quickly dynamically generate your level for projects in the Runner genre.

### WARNING: It only works on the Z coordinate (or one other coordinate, detailed in the instruction) and if all segments are the SAME SIZE. I plan to fix all this in the future.

### Instruction: 

1. Open GeneratorConfig
2. Enter:<br>
× ChunkSize - How many segments will be spawned/deleted at a time.<br>
× MaxActiveSegments - How many segments can exist at the same time.<br>
× SizeSegment - Size of 1 segment in the direction of the Z coordinate.<br>
× Index and Segment Prefab - Add an element to the Segments list, specify the index (if necessary) and the segment Prefab.<br>
3. Add GeneratorSegment on empty gameobject or on any other.
4. Specify:<br>
× GenaratorConfig - Config file.<br>
× Target - The object against which the level will spawn.<br>

#### IF YOU NEED OTHER AXIS:
If you need to change the axis at which the level will spawn, then: 
1. Change _target.position.z to your axis in line 22.
2. Swap _spawnPositionSegment with the newSegment.transform.position you need in line 39.

![Gif](https://github.com/nohatler/Runner-Level-Generator-Unity-3D/blob/main/Assets/Demo/RunnerGeneratorLevel.gif?raw=true)