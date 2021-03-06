# Procedural Crystal Twine

This is one of my first steps into procedural generation. Crystal twines like structures are part of my fictional world. I want to generate them for the game I'm developing by myself in Unity3D to save a bit of time and maybe bring some variety into the game world. It is also quite fun to broaden my own horizon.

The result should look like this basic sketch where the red dots are the vertices and the lines the edges:

<img src="https://github.com/cfloeth/ProceduralCrystalTwine/blob/main/Readme%20Images/CrystalTwine.png" alt="Basic sketch of a crystal twine" width="250"/>

## Goal ##
The crystal twines should be fully procedurally generated in these details:

- twine node path (node count, node orientations etc.)
- vertex count in each node neighbourhood (the mesh is divided into ring areas near each node)
- vertex position offsets
- material
- export function
- hopefully branches later on

The twine should look organic.

## Basic Algorithm ##
- place twine path nodes
- start at top node and place vertex at the same position
- choose next lower node
- add some vertices around the node based on radius
- repeat until last node
- offset vertices
- create mesh + material

## Status ##
- nodes have to be set manually (position, child of nodes container, radius)
- basic seeded generation (vertex count in node neighbourhood, vertex X,Y,Z offsets)
- gizmos for twine nodes (black) and vertices (red)
- custom editor for runtime mesh updates

## Next Steps ##
- creating the mesh (a mesh gets created, but triangle indices aren't correctly chosen for now. 'snowy tree'-feature)
- applying offsets for vertices based on node orientation and radius
- calculating node radius based on set radius instead of chosing random values (should look a bit more organic)
- considering node orientation while placing vertices and offsetting them
