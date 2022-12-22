library ieee;
use ieee.std_logic_1164.all;
entity split_motor1 is
	port(data_seg:in bit_vector(7 downto 0);
		motors:out bit_vector(3 downto 0);
		servo:out bit_vector(2 downto 0);
		speed:out bit);
end;
architecture behave of split_motor1 is
begin
motors<=data_seg(3 downto 0);
servo<=data_seg(6 downto 4);
--servo(0)<=data_seg(3);
--servo(1)<=data_seg(2);
--servo(2)<=data_seg(1);
speed<=data_seg(7);
end behave;

