library ieee;
use ieee.std_logic_1164.all;
entity split_motor is
	port(data_seg:in bit_vector(7 downto 0);
		motors:out bit_vector(3 downto 0);
		servo:out bit_vector(2 downto 0);
		speed:out bit);
end;
architecture behave of split_motor is
begin
motors<=data_seg(7 downto 4);
servo<=data_seg(3 downto 1);
speed<=data_seg(0);
end behave;

