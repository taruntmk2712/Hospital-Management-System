import java.awt.event.*;
import java.awt.*;
import java.applet.*;
/*<applet code=game width=1500 height=700></applet>*/
public class game extends Applet implements MouseListener{
	int [][] a= {{0,0,0},{0,0,0},{0,0,0}};//game grid
	int [][] b= {{0,0,0},{0,0,0},{0,0,0}};//main grid
	
	int x,y;//mouse position
	int bx,by;
	int p=1,pn=2;//player,next player(for shifting grids)
	int w=0,w2=0;//w->game grid win, w2->Overall win.
	int t=2;//Table played on.
	int c=0,c2=0;//Cout blocks on game & main grid respectively.
	int r=0;//Restart.
	int h=1;//Instruction
	
	public void init() {
		setBackground(Color.black);
		setForeground(Color.red);
		addMouseListener(this);
	}
	
	//Win condition for game grid
	public int win(int b) {
		for(int i=0;i<3;i++) {
			if(a[i][0]==b && a[i][1]==b && a[i][2]==b)
				return b;
			else if(a[0][i]==b && a[1][i]==b && a[2][i]==b)
				return b;
		}
		if(a[0][0]==b && a[1][1]==b && a[2][2]==b)
			return b;
		if(a[0][2]==b && a[1][1]==b && a[2][0]==b)
			return b;
		return 0;	
	}
	
	//Win condition for main grid
	public int win2(int a) {
		for(int i=0;i<3;i++) {
			if(b[i][0]==a && b[i][1]==a && b[i][2]==a)
				return a;
			else if(b[0][i]==a && b[1][i]==a && b[2][i]==a)
				return a;
		}
		if(b[0][0]==a && b[1][1]==a && b[2][2]==a)
			return a;
		if(b[0][2]==a && b[1][1]==a && b[2][0]==a)
			return a;
		return 0;	
	}
	//Checks if mouse has been clicked over valid position in game grid.
	public void check1() {
		x=(x-150)/150;
		y=(y-200)/150;
		if(x<3 && y<3 && a[x][y]==0) {
			if(p==1) {
				a[x][y]=1;
				w=win(p);
				p=2;
			}
			else {
				a[x][y]=2;
				w=win(p);
				p=1;
			}
			c++;
			if(c==9 && w==0)
				w=4;//Draw if board filled.
		}
	}
	
	//Checks if mouse has been clicked over vaild position in main grid.
	// It marks that location.Transfer control to game grid.
	public void check2() {
		x=(x-1150+300)/150;
		y=(y-200)/150;
		if(x<3 && y<3 && b[x][y]==0) {
			b[x][y]=3;
			bx=x;
			by=y;
			t=1;
		}
	}
	
	//It get's called when mouse is clicked.
	//Repaints the screen.
	public void mouseClicked(MouseEvent e) {
		int i,j;
		
		//Starts game if on help screen.
		if(h==1) {
			h=0;
			repaint();
			return;
		}
		//Restarts the game when game over.	
		//Calls the check function & checks Winner.  
		if(r==1) {
			for(i=0;i<3;i++)
				for(j=0;j<3;j++) {
					a[i][j]=0;
					b[i][j]=0;
				}
			p=1;pn=2;
			w=0;w2=0;
			t=2;
			c=0;c2=0;
			r=0;
			repaint();
			return;
			
		}
		
		x=e.getX();
		y=e.getY();
		if(t==1) {
			check1();
			if(w!=0) {
				b[bx][by]=w;//winner of game grid/draw assigned to main grid.
				c2++;
				
				t=2;//main grid.
				p=pn;
				if(pn==2) pn=1;
				else pn=2;
				
				w2=win2(w);//overall win.
				if(w2==4) w2=0;
				if(c2==9 && w2==0)
					w2=4;
			}
		}
		else {//reset the game grid.
			c=0;
			for(i=0;i<3;i++) {
				for(j=0;j<3;j++) {
					a[i][j]=0;
				}
			}
			if(w2==0)
				check2();
		}
		
		repaint();
	}
	
	public void mousePressed(MouseEvent e) {}
	
	public void mouseReleased(MouseEvent e){}
	   
	public void mouseEntered(MouseEvent e){}
	
	public void mouseExited(MouseEvent e){}
	

	//Draws both Grid
	public void tab(Graphics g) {
		int x=0;
		for(int k=0;k<2;k++) {
			for(int i=0;i<2;i++) {
				g.drawLine(300+i*150+x, 200, 300+i*150+x, 650);
			}
			for(int i=0;i<2;i++) {
				g.drawLine(150+x, 350+i*150, 600+x, 350+i*150);
			}
			x=700;
		}
	}
	
	//Fills Game Grid
	public void fillTab(Graphics g){
		g.setFont(new Font("Unicorn", Font.PLAIN, 100));
		for(int i=0;i<3;i++) {
			for(int j=0;j<3;j++) {
				if(a[i][j]==1)
					g.drawString("X", 175+i*150, 325+j*150);
				else if(a[i][j]==2)
					g.drawString("O", 175+i*150, 325+j*150);
				else if(a[i][j]==4)
					g.drawString("/", 175+i*150, 325+j*150);
			}
		}
	}
	
	//Fills Main Grid
	public void fillTab2(Graphics g){
		g.setFont(new Font("Unicorn", Font.PLAIN, 100));
		for(int i=0;i<3;i++) {
			for(int j=0;j<3;j++) {
				if(b[i][j]==1)
					g.drawString("X", 1175+i*150-300, 325+j*150);
				else if(b[i][j]==2)
					g.drawString("O", 1175+i*150-300, 325+j*150);
				else if(b[i][j]==3)
					g.drawString("~", 1175+i*150-300, 325+j*150);
				else if(b[i][j]==4)
					g.drawString("/", 1175+i*150-300, 325+j*150);
			}
		}
	}
	
	//Display Instruction. 
	public void help(Graphics g) {
		g.setFont(new Font("Sherwood",Font.BOLD,60));
		g.drawString("TIC-TAC-TOE 2.0",450,70);
		g.setFont(new Font("Sherwood", Font.PLAIN, 30));
		g.drawString("Instuctions", 605, 130);
		g.drawString("_________",600,140);

		String s[]= {"Do you have what it takes to be the ultimate tic tac toe champion?",
				"1. The game consists of two grids: the main grid and the game grid.",
				"   The objective is to win 3 in a row on the main grid.",
				"2. First you have to choose a block on the main grid.",
				"   This activates the game grid. Here you play a normal game of tic tac toe.",
				"   If you win, then you win that block on the main grid, else it's a draw. ",
				"3. Players take turns alternately. The first to get 3 in a row wins."};
		
		for(int i=0;i<7;i++) {
			g.drawString(s[i], 200, 200+60*i);
		}
		
		g.drawString("Click to Continue", 550, 650);
		
	}
	
	//Calls tab & fillTab.
	//Displays UI.
	public void paint(Graphics g) {	
		if(h==1) {
			help(g);
			return;
		}
		tab(g);	
		fillTab(g);
		fillTab2(g);
		g.setFont(new Font("Unicorn", Font.PLAIN, 50));
		//g.drawString(x+","+y+";"+c+";"+w+";"+w2, 100, 100);
		g.drawString("Tic-Tac-Toe 2.0", 500, 50);
		g.setFont(new Font("Unicorn", Font.PLAIN, 40));
		g.drawString("Game Grid",270 ,700);
		g.drawString("Main Grid",990 ,700);
		g.setFont(new Font("Unicorn", Font.PLAIN, 50));
		//Play over current grid.
		if(t==1)
			g.drawString("Play", 150, 150);
		else
			g.drawString("Play", 875, 150);
		
		if(w!=0) {
			if(w!=4)
				g.drawString("Player "+w+" Wins", 525, 100);
			else
				g.drawString("Draw", 600, 100);
			w=0;
		}
		if(w2!=0) {
			g.setColor(Color.WHITE);
			g.fillRect(0,0,2000,2000);
			g.setColor(Color.RED);
			g.setFont(new Font("Unicorn", Font.PLAIN, 100));
			if(w2!=4)	
				g.drawString("Player "+w2+" Wins Game", 300, 400);
			else 
				g.drawString("Draw", 600, 400);
			
			g.drawString("Click to Restart", 400, 600);
			r=1;
			
			setBackground(Color.black);
			setForeground(Color.red);
		}
	}
}
