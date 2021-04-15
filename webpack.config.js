const path = require('path');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const StylelintPlugin = require('stylelint-webpack-plugin');

module.exports = {
    entry: './dist/app/main.js',
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
            template: './src/index.html'
        }),
        new StylelintPlugin({
            configFile: 'stylelint.config.js',
            context: './src',
            files: '**/*.css',
            fix: true
        })
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
