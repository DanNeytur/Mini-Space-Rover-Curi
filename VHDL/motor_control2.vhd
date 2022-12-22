library ieee;
use ieee.std_logic_1164.all;
entity motor_control2 is
port( motors: in bit_vector(3 downto 0);
	pwm_in1,pwm_in2 : in bit;
	m1,m2,m3,m4: out bit);
end;
architecture behave of motor_control2 is
begin

m1<=pwm_in1 and motors(0);
m2<=pwm_in1 and motors(1);
m3<=pwm_in2 and motors(2);
m4<=pwm_in2 and motors(3);

end behave;

