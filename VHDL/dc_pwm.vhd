library ieee;
use ieee.std_logic_1164.all;
entity dc_pwm is
port( speed,clk: in bit;
		out_pwm: out bit);
end;

architecture behave of dc_pwm is
signal cnt: integer range 0 to 25174;
signal high: integer range 18881 to 23916;

begin

	 
	high<= 18881 when speed='0' else 23916;

	process(clk)
	begin
		if clk'event and clk='1' then
			if cnt<25174 then 
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





