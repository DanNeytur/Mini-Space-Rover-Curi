library ieee;
use ieee.std_logic_1164.all;
entity fdiv is
	port(fin: in bit;
		fout:buffer bit);
end;

architecture behave of fdiv is
signal cnt: integer range 0 to 81;
--counting up to 82--
begin
	process(fin)
	begin
 if fin'event and fin='1' then
		if cnt=81 then fout<=not fout;
		cnt<=0;
		else cnt<=cnt+1;
		end if;
     end if;
	end process;
end behave;
