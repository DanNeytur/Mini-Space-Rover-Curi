library ieee;
use ieee.std_logic_1164.all;

entity rx is
	port(clk,sin:in bit;
		Pout:out bit_vector(7 downto 0));
end;

architecture behave of rx is
signal info_flag: bit;
signal cnt: integer range 0 to 7;
signal stack:bit_vector(7 downto 0);
begin
	process(clk)
	begin
		if clk'event and clk='1' then
			if cnt=0 and sin='0' and info_flag='0' then
				info_flag<='1';
			elsif info_flag='1' then
				stack(cnt)<=sin;
				if cnt<7 then
					cnt<=cnt+1;
				else --cnt=7--
					info_flag<='0';
				end if;
			elsif cnt=7 and info_flag='0' then
				if sin='1' then
					Pout<=stack;
					cnt<=0;
				else
					Pout<=(others=>'1');--error=FF--
					cnt<=0;
					info_flag<='0';
				end if;
			else--default--
				cnt<=0;
				info_flag<='0';
			end if;
		end if;
	end process;
end behave;




