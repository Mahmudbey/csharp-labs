pkg load symbolic

disp('1-topshiriq')
%15-misol
syms x;
f = (sqrt(1+x)-sqrt(1-x))/((1+x)^(1/3)-(1-x)^(1/3));
% nthroot(x,n) da x ham haqiqiy son bo''lishi kerak
y = limit(f,0)

disp('2-topshiriq')
%12-misol
syms x;
y = x^4-3*x^3-8*x^2+12*x+16;
solve(y)'

syms x y;
y1 = 2/x+1/y-4;
y2 = 1/x-3/y -1/12;
[x y] = solve(y1, y2)

disp('3-topshiriq')
%1-misol
syms x k;
a = (-1)^2*k/(k*(2*k+1)*2^k);
s = symsum(a, 1, inf);
pretty(s)

disp('4-topshiriq')
%10-misol
syms x;
f = exp(x)*(1+sin(x))/(1+cos(x));
disp('1-tartibli hosila:')
pretty(diff(f))
disp('2-tartibli hosila:')
pretty(diff(f,2))

disp('5-topshiriq')
%1-misol
syms x;
f = log(x)/(x*sqrt(1+log(x)));
disp('Aniqmas integral:')
pretty(int(f))
disp('Aniq integral, (1, 3.5):')
pretty(int(f, 1, 3.5))

disp('6-topshiriq')
%23-misol
syms x;
%f = (sin(x))^10*cos(x);
y = dsolve('Dx=(sin(x))^10*cos(x)', 'x(1)=1')
%pretty(y)

syms x y t;
[x, y] = dsolve('Dx=3*x+2*y+4*exp(5*t)', 'Dy=x+2*y', 'x(0)=0', 'y(0)=0')
disp('x=')
pretty(x)
disp('y=')
pretty(y)
