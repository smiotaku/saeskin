procedure SetupResource(const AName, ASuffix: string);
begin
  FindResource(AName).Set('ID', AName + '.' + ASuffix);
end;

procedure SetupTheme(const ASuffix: string);
begin
  SetupResource('Skin.Color.BottomPanel.Background', ASuffix);
end;

procedure Execute(var State: Integer);
begin
  BeginUpdateResources;
  case State of
    0: SetupTheme('Dark');
    1: SetupTheme('Colored');      
  end;
  EndUpdateResources;
end;
