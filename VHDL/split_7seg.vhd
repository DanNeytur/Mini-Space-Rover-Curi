library ieee;
use ieee.std_logic_1164.all;
entity split_7seg is
	port(data_seg:in bit_vector(7 downto 0);
		high,low:out bit_vector(3 downto 0));
end;
architecture behave of split_7seg is
begin
high<=data_seg(7 downto 4);
low<=data_seg(3 downto 0);
end behave;

		
