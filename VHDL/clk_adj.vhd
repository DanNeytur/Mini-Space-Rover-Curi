library ieee;
use ieee.std_logic_1164.all;
entity clk_adj is
	port(clk_in:in bit;
		clk_out:buffer bit);
end;

architecture behave of clk_adj is
begin
	process(clk_in)
	begin
		if clk_in'event and clk_in='1' then
			clk_out<=not clk_out;
		end if;
	end process;
end behave;
