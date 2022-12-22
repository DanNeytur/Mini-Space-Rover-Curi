library ieee;
use ieee.std_logic_1164.all;

entity info_mux is
	port(data:in bit_vector(7 downto 0);
		motors:out bit_vector(3 downto 0);
		speed1,speed2:out bit;
		servo_cam,servo_claw,servo_arm:out bit_vector(2 downto 0));
end;

architecture behave of info_mux is
begin

motors<=data(3 downto 0) when data(7 downto 6)="00";
speed1<=data(4) when data(7 downto 6)="00";		
speed2<=data(5) when data(7 downto 6)="00";
servo_cam<=data(2 downto 0) when data(7 downto 6)="01";
servo_arm<=data(5 downto 3) when data(7 downto 6)="01";		
servo_claw<=data(2 downto 0) when data(7 downto 6)="10";

end behave;	
