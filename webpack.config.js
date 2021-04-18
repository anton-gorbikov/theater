const path = require('path');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const StylelintPlugin = require('stylelint-webpack-plugin');
const CopyPlugin = require('copy-webpack-plugin');

module.exports = {
    entry: './dist/tmp/main.js',
    devServer: {
        contentBase: './dist/app',
        historyApiFallback: true,
        host: '0.0.0.0',
        port: 4200
    },
    plugins: [
        new CleanWebpackPlugin(),
        new HtmlWebpackPlugin({
            title: 'Theater',
            template: './src/app/index.html'
        }),
        new StylelintPlugin({
            configFile: 'stylelint.config.js',
            context: './src/app',
            files: '**/*.css',
            fix: true
        }),
        new CopyPlugin({
            patterns: [
              { from: 'src/app/package.json', to: '' },
              { from: 'dist/tmp/index.js', to: '' },
              { from: 'dist/tmp/.fable', to: '.fable/' },
            ],
          }),
    ],
    output: {
        filename: 'main.js',
        path: path.resolve(__dirname, 'dist/app')
    },
    module: {
        rules: [{
            test: /\.css$/,
            use: [
                'style-loader',
                'css-loader',
                'postcss-loader'
            ]
        }]
    }
};
