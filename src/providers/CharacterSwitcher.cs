procedure SetupResource(const AName, ASuffix: string);
begin
  FindResource(AName).Set('ID', AName + '.' + ASuffix);
end;

procedure SetupTheme(const ASuffix: string);
begin
  SetupResource('Skin.TextureEx.Characters', ASuffix);
  SetupResource('Skin.TextureEx.Tray.Character', ASuffix);
  SetupResource('Skin.TextureEx.ShowCase.Character', ASuffix);
  SetupResource('Skin.TextureEx.Character.NowPlay', ASuffix);
end;

procedure Execute(var State: Integer);
begin
  BeginUpdateResources;
  case State of
    0: SetupTheme('None');
    1: SetupTheme('1');      
    2: SetupTheme('2');
    3: SetupTheme('3');  
    4: SetupTheme('4');
    5: SetupTheme('5');      
    6: SetupTheme('6');
    7: SetupTheme('7');  
    8: SetupTheme('8');
    9: SetupTheme('9');  
    10: SetupTheme('10');
    11: SetupTheme('11');
    12: SetupTheme('12');
    13: SetupTheme('13');
    14: SetupTheme('14');
    15: SetupTheme('15');
    16: SetupTheme('16');
    17: SetupTheme('17');
    18: SetupTheme('18');
    19: SetupTheme('19');
    20: SetupTheme('20');
    21: SetupTheme('21');
    22: SetupTheme('22');
    23: SetupTheme('23');
    24: SetupTheme('24');
    25: SetupTheme('25');    
  end;
  EndUpdateResources;
end;