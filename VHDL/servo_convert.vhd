library ieee;
use ieee.std_logic_1164.all;
entity servo_convert is
		port(angle_num : in integer range 0 to 7;
			clk: in bit;
			angle_pwm: out bit);
end;


architecture behave of servo_convert is
signal count: integer range 0 to 251749;
signal high: integer range 25175 to 50350;
begin
	with angle_num select
		high<=  25715 when 0,
				28771 when 1,
				32368 when 2,
				35964 when 3,
				39561 when 4,
				43157 when 5,
				46753 when 6,
				50350 when others;
				
	process(clk)
	begin
		if clk'event and clk='1' then
			if count<251749 then
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
