int SW = 7;

int inf;

int ppx;
int ppy;

int px;
int py;

int sx;
int sy;

void setup() {

Serial.begin(9600);
for(int u = 2; u < 4; u++){
  pinMode(u,OUTPUT);
}

for(int u = 5; u < 8; u++){
  pinMode(u,OUTPUT);
}

}

void loop() {
  // put your main code here, to run repeatedly:
digitalWrite(3,1);
digitalWrite(2,0);

ppx = analogRead(A1);
ppy = analogRead(A0);
inf = digitalRead(SW);

px = map(ppx,0,1023,-99,99);
py = map(ppy,0,1023,-99,99);

if(px < 0){
  px = 100 + px * (-1);
  Serial.print(px);
  Serial.print(" ");
  Serial.print(0);
}
else{
  px = px + 100;
  Serial.print(px);
  Serial.print(" ");
  Serial.print(1);
}
Serial.print(" ");
if(py < 0){
  py = 100 + py * (-1);
  Serial.print(py);
  Serial.print(" ");
  Serial.print(0);
}
else{
  py = py + 100;
  Serial.print(py);
  Serial.print(" ");
  Serial.print(1);
}

Serial.println("");

}
