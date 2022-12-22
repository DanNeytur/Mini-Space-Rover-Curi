library ieee;
use ieee.std_logic_1164.all;
entity servo_convert1 is
		port(angle_num : in integer range 0 to 7;
			clk: in bit;
			angle_pwm: out bit);
end;


architecture behave of servo_convert1 is
signal count: integer range 0 to 3067;
signal high: integer range 92 to 368;
begin
	with angle_num select
		high<=  92 when 0,
				131 when 1,
				171 when 2,
				210 when 3,
				250 when 4,
				289 when 5,
				328 when 6,
				368 when others;

				
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
