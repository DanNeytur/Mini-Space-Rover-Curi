library ieee;
use ieee.std_logic_1164.all;
entity dc_pwm1 is
port( speed,clk: in bit;
		out_pwm: out bit);
end;

architecture behave of dc_pwm1 is
signal cnt: integer range 0 to 153;
signal high: integer range 99 to 145;--65/95%

begin

	 
	high<= 99 when speed='0' else 145;

	process(clk)
	begin
		if clk'event and clk='1' then
			if cnt<152 then 
				cnt<=cnt+1;
			else 
				cnt<=0;
			end if;

			if cnt<high then
				out_pwm<='1';
			else 
				out_pwm<='0';
			end if;
		end if;
	end process;
end behave;





