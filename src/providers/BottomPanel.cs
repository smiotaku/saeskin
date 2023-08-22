procedure Execute(var State: Integer); 
var
	Bottom: TComponent;    
begin    
	Bottom := FindObject('mwBotCont');
    
	case State of
		0:
		   begin
			Bottom.BeginUpdate;
			Bottom.Set('Texture.ID', 'Skin.TextureEx.Window.Shadow.Rounded.Bottom');
			Bottom.EndUpdate;
		   end;
		1: 
		   begin
			Bottom.BeginUpdate;
      Bottom.Set('Texture.ID', 'Skin.TextureEx.Window.Shadow.Rounded.Bottom.2nd');
			Bottom.EndUpdate;
		   end;
	end;
end;