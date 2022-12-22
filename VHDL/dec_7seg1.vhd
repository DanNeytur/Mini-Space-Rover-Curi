library ieee;
use ieee.std_logic_1164.all;
entity dec_7seg1 is 
port(data_in: in bit_vector(3 downto 0);
	data_out: out bit_vector(7 downto 0));
end;

architecture behave of dec_7seg1 is
begin

with data_in select
		data_out<= "11000000" when "0000",
				"11111001" when "0001",
				"10100100" when "0010",
				"10110000" when "0011",
 				"10011001" when "0100",
				"10010010" when "0101",
				"10000010" when "0110",
				"11111000" when "0111",
				"10000000" when "1000",
				"10010000" when "1001", 
				"10001000" when "1010",
				"10000011" when "1011",
				"11000110" when "1100",
				"10100001" when "1101",
				"10000110" when "1110",
				"10001110" when others;
end behave;

