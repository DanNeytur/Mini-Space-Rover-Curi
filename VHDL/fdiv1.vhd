library ieee;
use ieee.std_logic_1164.all;
entity fdiv1 is
	port(fin: in bit;
		fout:buffer bit);
end;

architecture behave of fdiv1 is
signal cnt: integer range 0 to 162;
--counting up to 326= 153374hz--
begin
	process(fin)
	begin
 		if fin'event and fin='1' then
			if cnt=162 then 
				fout<=not fout;
				cnt<=0;
			else cnt<=cnt+1;
		end if;
     end if;
	end process;
end behave;
