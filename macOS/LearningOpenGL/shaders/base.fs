#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;
uniform float mix_factor;

void main()
{
//    FragColor = texture(ourTexture, TexCoord) * vec4(ourColor, 1.0);
    FragColor = mix(texture(texture1, vec2(TexCoord.x * 0.5, TexCoord.y * 0.5)), texture(texture2, TexCoord), mix_factor);
//    FragColor_1 = vec4(1.0, 0.5, 0.5, 1.0);
}
