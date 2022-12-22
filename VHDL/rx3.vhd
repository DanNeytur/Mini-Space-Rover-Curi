library ieee;
use ieee.std_logic_1164.all;

entity rx3 is
	port(clk,sin:in bit;
		Pout:out bit_vector(7 downto 0));
end;

architecture behave of rx3 is
signal start_bit,clr,tmp: bit;
signal cnt: integer range 0 to 160;
signal stack:bit_vector(9 downto 0);
begin

	process(clr,sin)
	begin
		if clr ='1' then
			start_bit<='0';
		elsif sin'event and sin='0' then
			start_bit<='1';
		end if;	
	end process;
	process(clk,clr)
	begin
		if clr='1' then
			cnt<=0;
		elsif clk'event and clk='1' then
			if start_bit='1' then
				if cnt<160 then------counter---------
					cnt<=cnt+1;
				else
					cnt<=0;
				end if;
				
				if cnt=8 then stack(0)<=sin; 
				elsif cnt=24 then stack(8)<=sin; 
				elsif cnt=40 then stack(7)<=sin;
				elsif cnt=56 then stack(6)<=sin; 
				elsif cnt=72 then stack(5)<=sin;
				elsif cnt=88 then stack(4)<=sin; 
				elsif cnt=104 then stack(3)<=sin;
				elsif cnt=120 then stack(2)<=sin; 
				elsif cnt=136 then stack(1)<=sin;
				elsif cnt=152 then stack(9)<=sin; 
				end if;	
				if cnt=158 then
					if stack(0)='0' and stack(9)='1' then
						Pout<=stack(8 downto 1);
					else
						Pout<="11111111";
					end if;
				end if;
			end if;
		end if;
	end process;
	
	clr<= 	'1' when cnt=160 else
			'0';
end behave;
