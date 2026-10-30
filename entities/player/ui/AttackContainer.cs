using Godot;
using System;

public partial class AttackContainer : PanelContainer
{

	  [Export]
	  public TextureRect @TextureRect { set; get; }
	  
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
}
