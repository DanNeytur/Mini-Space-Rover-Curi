library ieee;
use ieee.std_logic_1164.all;
entity claw_convert is
		port(angle_num : in integer range 0 to 7;
			clk: in bit;
			angle_pwm: out bit);
end;


architecture behave of claw_convert is
signal count: integer range 0 to 3067;
signal high: integer range 120 to 208;
begin
	with angle_num select
		high<=  120 when 0,
				132 when 1,
				145 when 2,
				158 when 3,
				170 when 4,
				183 when 5,
				195 when 6,
				208 when others;

				
	process(clk)
	begin
		if clk'event and clk='1' then
			if count<3066 then
				count<= count+1;
			else 
				count<=0;
			end if;			

			if count<high then
				angle_pwm<='1';
			else 
				angle_pwm<='0';
			end if;
		end if;
	end process;
end behave;

