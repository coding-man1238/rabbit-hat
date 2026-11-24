using Godot;
using System;

[GlobalClass]
public partial class Level : Node2D
{
	const int ROOM_COUNT = 15;
	static Vector2I[] DIRECTIONS = { Vector2I.Down, Vector2I.Left, Vector2I.Right, Vector2I.Up };

	public Vector2I[] Rooms { private set; get; }

	public Vector2I[] Generate()
	{
		Vector2I current_pos = Vector2I.Zero;
		Vector2I[] rooms = new Vector2I[ROOM_COUNT];
		rooms[0] = current_pos;

		for (int i = 1; i < ROOM_COUNT; i++)
		{
			Vector2I new_pos;
			do
			{
				new_pos = current_pos + DIRECTIONS[GD.Randi() % 4];
			} while (Array.IndexOf(rooms, new_pos) != -1);
			rooms[i] = new_pos;
			current_pos = rooms[GD.Randi() % (i + 1)];
		}

		return rooms;
	}

	public override void _Ready()
	{
		Rooms = Generate();
		QueueRedraw();
	}

	public override void _Draw()
	{
		foreach (Vector2I room in Rooms)
		{
			DrawRect(new Rect2(room * 40, new(32, 32)), Colors.Red);
		}
	}
}
