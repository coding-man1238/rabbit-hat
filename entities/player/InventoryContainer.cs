using Godot;
using System;

[Tool]
public partial class InventoryContainer : PanelContainer
{
	[Export]
	public Container ItemContainer { set; get; }

	bool _expanded = false;

	[Export]
	public bool Expanded
	{
		set
		{
			_expanded = value;
			GD.Print("hello world");
			if (ItemContainer is not null)
			{
				  ItemContainer.CustomMaximumSize = ItemContainer.CustomMaximumSize with { Y = value? 324:72 };
			}
		}
		get => _expanded;
	}

	public void ToggleSize() => Expanded = !Expanded;
}
