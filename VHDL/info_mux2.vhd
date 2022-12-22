library ieee;
use ieee.std_logic_1164.all;

entity info_mux2 is
	port(data:in bit_vector(7 downto 0);
		clk:in bit;
		motors:out bit_vector(3 downto 0);
		speed1,speed2:out bit;
		servo_cam,servo_claw,servo_arm:out bit_vector(2 downto 0));
end;

architecture behave of info_mux2 is
begin
	process(clk)
	begin
		if clk'event and clk='1' then
			if data(7 downto 6)="00" then
				motors<=data(3 downto 0);
				speed1<=data(4);	
				speed2<=data(5);
			elsif data(7 downto 6)="01" then
			servo_cam<=data(2 downto 0);
			servo_arm<=data(5 downto 3);
			elsif data(7 downto 6)="10" then
			servo_claw<=data(2 downto 0);
			end if;
		end if;
	end process;
end behave;	
