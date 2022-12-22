library ieee;
use ieee.std_logic_1164.all;
entity rx2 is
port ( clk, si  : in bit;
       y : out bit_vector(7 downto 0));
end ;
architecture behave of rx2 is
signal start_bit , stop_bit, clr , start : bit;
signal buf : bit_vector ( 7 downto 0);
signal cnt : integer range 0 to 255;
begin
--------------- checking the start bit -----------------
process (si,clr)
begin
if  clr='1' then
	start<='0';
elsif si'event and si='0' then 
	start<='1';
end if;
end process;
--------------------- data recieving --------------
process (clk,clr)
begin
if clr='1' then
	cnt<=0;
    buf<="00000000";
elsif clk'event and clk='1' then
	if start='1' then
if cnt<160 then cnt<=cnt+1; else cnt<=0; end if;
if    cnt=8  then start_bit<=si;
elsif cnt=24 then buf(0)<=si;
elsif cnt=40 then buf(1)<=si;
elsif cnt=56 then buf(2)<=si;
elsif cnt=72 then buf(3)<=si;
elsif cnt=88 then buf(4)<=si;
elsif cnt=104 then buf(5)<=si;
elsif cnt=120 then buf(6)<=si;
elsif cnt=136 then buf(7)<=si;
elsif cnt=152 then stop_bit<=si;
elsif cnt=158 and start_bit='0' and stop_bit='1' then 
	y<=buf; 
end if;
end if;
end if;
end process;
clr<='1' when cnt=160 else '0';
end behave;

