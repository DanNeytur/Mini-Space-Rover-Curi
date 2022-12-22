library ieee;
use ieee.std_logic_1164.all;
entity arm_convert is
		port(angle_num : in integer range 0 to 7;
			clk: in bit;
			angle_pwm: out bit);
end;


architecture behave of arm_convert is
signal count: integer range 0 to 3067;
signal high: integer range 170 to 271; 
begin
	with angle_num select
		high<=  170 when 0,
				184 when 1,
				199 when 2,
				213 when 3,
				228 when 4,
				242 when 5,
				256 when 6,
				271 when others;

				
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

