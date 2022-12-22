library ieee;
use ieee.std_logic_1164.all;
entity servo_stable is
	port(num:in integer range 92 to 368;
		clk50: in bit;
		output:buffer integer range 92 to 368);
end;

architecture behave of servo_stable is
signal cnt:integer range 0 to 5;
begin
	process(clk50)
	begin
		if clk50'event and clk50='1' then
			if cnt<4 then
				cnt<=cnt+1;
			else
				cnt<=0;
				
				
				if num<output then
					num<=num+1;
				elsif num>output then
					
			end if;
