# Geometrik-Library

<h1>O que é Geometrik?</h1>
<p><strong>Geometrik</strong> é uma biblioteca de classes escrita em C# que permite ao programador adicionar elementos gráficos de formas geométrica com poucas linhas de código em seus projetos.</p>

<p>Por enquanto, esta biblioteca contém poucas formas geométricas, limitando-se apenas a <em>círculos, elipses, quadrados, retângulos e triângulos com catetos iguais</em>. Porém, novas formas serão adicionadas com o tempo. Além das formas geométricas já contidas na biblioteca, o programador também tem a liberdade de, utilizando-se de classes da própria DLL, criar as suas próprias formas geométricas perssonalizadas.</p>
</br>
Geometrik contém três classes para desenho de formas geométricas:

* Ball - Para desenhar círculos preenchidos, círculos não preenchidos e elipses.

* Rectang - Para desenhar quadrados e retângulos.

* Triangle - para desenhar triângulos com catetos iguais.

<h2>COMO DESENHAR COM GEOMETRIK?</h2>
para desenhar na tela, basta criar uma instância da classe da forma geométrica que deseja desenhar e passar os valores de seus argumentos que são, por padrão: 

* height - altura

* Width - largura

* posX - posição x

* posY - posição y

* fill - true se a forma geométrica for preenchida, false se não.

<b>EX.: Ball bola = new Ball(50, 50, 10, 10, true);</b>

por padrão, a forma geométrica tem a cor <strong>vermelha</strong>, mas se o programador desejar alguma outra cor para o seu desenho, ele pode fazer isso modificando o valor da propriedade <strong>ColorObject</strong> do objeto.

<b>EX.: bola.ColorObject = System.Drawing.Color.Green;</b>

Com este simples código, agora temos uma bola verde, mas ainda falta desenhá-la na tela. Para desenhar uma forma geométrica na tela após ter instânciado um objeto da forma desejada utilizando Geometrik, basta chamar o método <strong>DrawFormat</strong> e passar um <strong>PaintEventArgs</strong> como argumento.
'''
<h3>Exemplos</h3>
<h4>Este exemplo desenha um quadrado azul 50 x 50 preenchido na tela:</h4>
<p>private void panel_square(object sender, PaintEventArgs e)</p>
<p>{</p>
<p>   Rectang square = new Rectang(50, 50, 0, 0, true);</p>
<p>   square.ColorObject = System.Drawing.Color.Blue;</p>
<p>   square.DrawFormat(e);</p>
<p>}</p>
'''
