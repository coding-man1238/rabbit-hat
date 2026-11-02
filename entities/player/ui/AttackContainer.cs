using Godot;
using System;

public partial class AttackContainer : PanelContainer
{
	  [Export]
	  public TextureRect @TextureRect { set; get; }

	  [Export]
	  public Label IndexLabel { set; get; }
	  
	  [Export]
	  public AttackRes @AttackRes
	  {
			set {
				field = value;
				if (@TextureRect is not null)
					  @TextureRect.Texture = value.Icon;
			}
			get;
	  }

	  public override void _Ready()
	  {
			IndexLabel.Text = ' ' + (GetIndex() + 1).ToString();
	  }

	  public Node2D GetNode() {
			if (@AttackRes is null) return null;
			return @AttackRes.AttackScene.Instantiate<Node2D>();
	  }
}
